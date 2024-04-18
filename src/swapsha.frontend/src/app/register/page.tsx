'use client'

import {useState} from "react";
import RegisterStepOne from "@/components/register/register-step-one";


const RegisterPage = () => {
  const [formData, setFormData] = useState({
    email: '',
    password: ''
  });
  const [step, setStep] = useState(1);

  const nextStep = () => {
    setStep(prevStep => prevStep + 1);
  };

  const prevStep = () => {
    setStep(prevStep => prevStep - 1);
  };

  const handleFormData = (newData: any) => {
    setFormData(prevData => ({
      ...prevData,
      ...newData
    }));
  };

  return (
    <div className="h-screen flex items-center">
      {step === 1 && <RegisterStepOne nextStep={nextStep} handleFormData={handleFormData}/>}
    </div>
  );
};

export default RegisterPage;