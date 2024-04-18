'use client'

import {useState} from "react";
import RegisterStepOne from "@/components/register/register-step-one";


const RegisterPage = () => {
  const [step, setStep] = useState(1);

  const nextStep = () => {
    setStep(prevStep => prevStep + 1);
  };

  const prevStep = () => {
    setStep(prevStep => prevStep - 1);
  };

  return (
    <div className="h-screen flex items-center">
      {step === 1 && <RegisterStepOne/>}
    </div>
  );
};

export default RegisterPage;