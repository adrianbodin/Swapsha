import React, { FC, useRef } from 'react';
import Image from "next/image";

interface EditProfilePicProps{
  profilePicUrl: string
}

const EditProfilePic: FC<EditProfilePicProps> = ({ profilePicUrl }) => {
  const fileInputRef = useRef<HTMLInputElement>(null);

  const handleButtonClick = () => {
    fileInputRef.current?.click();
  };

  const handleFileChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const file = event.target.files?.[0];
    if (file) {
      //TODO this should probably let the user accept the file or not
      console.log(file);
    }
  };

  return (
    <div className="relative">
      <div className="relative w-80 h-80 overflow-hidden rounded-full">
        <Image
          //TODO fix some kind of backup image for this
          src={profilePicUrl}
          alt="Profile picture"
          fill
          objectFit="cover"
        />
      </div>
      <button
        onClick={handleButtonClick}
        className="absolute right-7 bottom-7 shadow-gray-400 shadow-md bg-main-white rounded-full w-1/8 h-10 w-10 flex justify-center items-center">
        <span className="material-symbols-outlined">edit</span>
      </button>
      <input
        ref={fileInputRef}
        type="file"
        accept="image/*"
        onChange={handleFileChange}
        className="hidden"
      />
    </div>
  )
};

export default EditProfilePic;