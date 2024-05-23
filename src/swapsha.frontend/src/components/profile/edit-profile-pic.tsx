'use client'
import React, {FC, useEffect, useRef, useState} from 'react';
import Image from "next/image";
import Dialog from "@/components/dialog";
import {cropToSquare} from "@/helpers/crop-image-to-circle";
import {updateProfilePicture} from "@/fetching/profile";
import {toast} from "sonner";
import {useMutation, useQueryClient} from "@tanstack/react-query";

interface EditProfilePicProps{
  picUrl: string;
  userId: string;
}


//TODO fix a bug here where the new image does not show directly
const EditProfilePic: FC<EditProfilePicProps> = ({ picUrl, userId }) => {
  const fileInputRef = useRef<HTMLInputElement>(null);
  const [isDialogOpen, setIsDialogOpen] = useState(false);
  const [croppedImage, setCroppedImage] = useState<File | null>(null);
  const [cacheBuster, setCacheBuster] = useState(Date.now());
  const queryClient = useQueryClient();


  const mutation = useMutation({
    mutationFn: (newProfilePic: File) => {
      return updateProfilePicture(newProfilePic, userId)
    },
    onSuccess: async () => {
      //This makes it update the queries that will not be in sync after the post
      await queryClient.invalidateQueries({ queryKey: ['profile', userId] });
      //This fixed everything with the image not updating, it's because the
      //caching in the browser that caches the image, and don't fetch the new image
      //because it is the same url
      setCacheBuster(Date.now()); // Update the cache-buster
      toast.success("Your profile picture was successfully updated.");
    },
    onError: () => {
      toast.error("There was an error uploading your profile picture.")
    }
  })

  const handleButtonClick = () => {
    fileInputRef.current?.click();
  };

  const handleFileChange = async (event: React.ChangeEvent<HTMLInputElement>) => {
    const file = event.target.files?.[0];
    if (file) {
      cropToSquare(file, {x:0, y:0, width:400, height:400})
        .then((croppedImage) => {
          if (croppedImage) {
            setCroppedImage(croppedImage);
            setIsDialogOpen(true);
          } else {
            console.log('Cropped image is null');
          }
        })
        .catch((error) => {
          console.error('Error cropping image:', error);
        });
    }
  };

  const uploadNewProfilePic = () => {
    if (croppedImage) {
      console.log("mutate")
      mutation.mutate(croppedImage);
    }
    setIsDialogOpen(false);
  }

  return (
    <div className="relative">
      <div className="relative w-96 h-96 overflow-hidden rounded-full">
        {picUrl && (
          <Image
            src={`${picUrl}?${cacheBuster}`}
            alt="Profile picture"
            fill
            sizes="1000px"
            className="object-cover"
            priority={true}
          />
        )}
      </div>
      <button
        onClick={handleButtonClick}
        className="absolute right-9 bottom-9 shadow-gray-400 shadow-md bg-main-white rounded-full w-1/8 h-10 w-10 flex justify-center items-center">
        <span className="material-symbols-outlined">edit</span>
      </button>
      <input
        ref={fileInputRef}
        type="file"
        accept="image/*"
        onChange={handleFileChange}
        className="hidden"
      />
      {isDialogOpen && (
        <Dialog onNo={() => setIsDialogOpen(false)} onYes={uploadNewProfilePic}>
          <div className="relative w-64 h-64 lg:h-80 lg:w-80 overflow-hidden rounded-full">
            {croppedImage && (
              <Image
                src={URL.createObjectURL(croppedImage)}
                alt="Profile picture"
                fill
                objectFit="cover"
              />
            )}
          </div>
          <h4 className="font-bold text-lg lg:text-xl text-center">Are you sure you want to change profile picture to this one?</h4>
        </Dialog>
      )}
    </div>
  );
};

export default EditProfilePic;