import React, {FC, useEffect, useState} from 'react';
import Input from "@/components/input";
import {cropToCircle} from "@/helpers/crop-image-to-circle";

interface RegisterStepThreeProps {
  handleFormData: (data:any) => void;
  submitRegisterForm: () => void;
}

const RegisterStepThree: FC<RegisterStepThreeProps> = ({  handleFormData, submitRegisterForm }) => {
  const [selectedImage, setSelectedImage] = useState<File | null>(null);
  const [cropedImage, setCropedImage] = useState<File | null>(null);

  useEffect(() => {
    cropToCircle(selectedImage, {x:0, y:0, width:400, height:400}).then((croppedImage) => {
      setCropedImage(croppedImage);
    });
  }, [selectedImage]);

  const handleImageChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    if (e.target.files && e.target.files[0]) {
      setSelectedImage(e.target.files[0]);
    }
  };

  const handleNext = () => {
    if (cropedImage) {
      handleFormData({ profilePicture: cropedImage});
      submitRegisterForm();
    }
  };

  return (
    <div className="flex flex-col items-center gap-4">
      <h3 className="font-bold text-lg">Please choose a profile picture for yourself!</h3>
      {cropedImage && <img src={URL.createObjectURL(cropedImage)} alt="Profile Picture" className="w-full"/>}
      <Input type="file" placeholder="Choose File" name="profilePicture" onChange={handleImageChange}/>
      {cropedImage &&
          <button
              className="inline-block px-4 py-2 text-main-white w-full bg-light-green rounded-xl"
              onClick={handleNext}>
              Register
          </button>}
    </div>
  );
};

export default RegisterStepThree;