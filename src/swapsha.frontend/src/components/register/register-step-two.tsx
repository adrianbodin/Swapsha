import React, {FC, useState} from 'react';
import Link from "next/link";
import Input from "@/components/input";

interface RegisterStepTwoFormData {
  firstName: string;
  middleName?: string;
  lastName: string;
}

interface RegisterStepTwoProps {
  prevStep: () => void;
  nextStep: () => void;
  handleFormData: (data:any) => void;
}

const RegisterStepTwo: FC<RegisterStepTwoProps> = ({prevStep,nextStep,handleFormData}) => {
  const [formData, setFormData] = useState<RegisterStepTwoFormData>({
    firstName: '',
    middleName: '',
    lastName: ''
  });
  const [errors, setErrors] = useState<RegisterStepTwoFormData>({
    firstName: '',
    middleName: '',
    lastName: ''
  });

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    });
  };

  function validate(){
    let tempErrors: RegisterStepTwoFormData = {
      firstName: formData.firstName ? "" : "First Name is required.",
      middleName: "",
      lastName: formData.lastName ? "" : "Last Name is required.",
    };

    if (formData.firstName.length > 50) {
      tempErrors.firstName = "First Name must be less than 50 characters.";
    }

    if (formData.middleName && formData.middleName.length > 50) {
      tempErrors.middleName = "Middle Name must be less than 50 characters.";
    }

    if (formData.lastName.length > 50) {
      tempErrors.lastName = "Last Name must be less than 50 characters.";
    }

    setErrors(tempErrors);

    return Object.values(tempErrors).every(x => x === "");
  }

  function handleNext(){
    if(validate()){
      handleFormData(formData);
      nextStep()
    }
  }

  return (
    <div className="flex flex-col gap-4">
      <div>
        <h2 className="text-2xl font-bold">What is your name?</h2>
      </div>
      <Input type="text" placeholder="First Name" name="firstName" onChange={handleChange} error={errors.firstName}/>
      <Input type="text" placeholder="Middle Name (Optional)" name="middleName" onChange={handleChange} error={errors.middleName}/>
      <Input type="text" placeholder="Last Name" name="lastName" onChange={handleChange} error={errors.lastName}/>
      <button
        className="inline-block px-4 py-2 text-main-white w-full bg-light-green rounded-xl"
        onClick={handleNext}>
        Continue
      </button>
    </div>
  );
};

export default RegisterStepTwo;