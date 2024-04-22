'use client'

import RegisterStepOne from "@/components/register/register-step-one";
import RegisterStepTwo from "@/components/register/register-step-two";
import RegisterStepThree from "@/components/register/register-step-three";
import useRegister from "@/hooks/useRegister";


const RegisterPage = () => {
  const {step, nextStep, handleFormData, submitRegisterForm} = useRegister();

  return (
    <div className="h-screen flex items-center">
      {step === 1 && <RegisterStepOne nextStep={nextStep} handleFormData={handleFormData}/>}
      {step === 2 && <RegisterStepTwo nextStep={nextStep} handleFormData={handleFormData}/>}
      {step === 3 && <RegisterStepThree submitRegisterForm={submitRegisterForm}  handleFormData={handleFormData}/>}
    </div>
  );
};

export default RegisterPage;