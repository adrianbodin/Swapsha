import React, {FC, useState} from 'react';
import Input from "@/components/input";
import Link from "next/link";

interface RegisterStepOneProps {
  nextStep: () => void;
  handleFormData: (data: any) => void;
}

const RegisterStepOne: FC<RegisterStepOneProps> = ({ nextStep, handleFormData }) => {
  const [formData, setFormData] = useState({
    email: '',
    confirmEmail: '',
    password: '',
    confirmPassword: ''
  });
  const [errors, setErrors] = useState<RegistrationStepOneErrors>({
    email: "",
    confirmEmail: "",
    password: "",
    confirmPassword: ""
  });

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    });
  };

  //This will run when going to next page in the register form
  function handleNext(){
    if(validate()){
      const dataToSend = {
        email: formData.email,
        password: formData.password
      };

      // Send this data to the parent
      handleFormData(dataToSend);
      nextStep()
    }
  }

  const validate = () => {
    let tempErrors: RegistrationStepOneErrors = {
      email: formData.email ? "" : "Email is required.",
      confirmEmail: formData.confirmEmail ? "" : "Confirm Email is required.",
      password: formData.password ? "" : "Password is required.",
      confirmPassword: formData.confirmPassword ? "" : "Confirm password is required."
    };

    if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(formData.email)) {
      tempErrors.email = "Email is not valid.";
    }

    if (formData.password !== formData.confirmPassword) {
      tempErrors.confirmPassword = "Password and confirm password do not match.";
    }

    if(formData.email !== formData.confirmEmail){
      tempErrors.confirmEmail = "Email and confirm email do not match."
    }

    if (formData.password.length < 10) {
      tempErrors.password = "Password must be at least 10 characters.";
    }

    if (!/[A-Z]/.test(formData.password)) {
      tempErrors.password = "Password must contain at least one capital letter.";
    }

    if (!/[!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?]/.test(formData.password)) {
      tempErrors.password = "Password must contain at least one special character.";
    }

    setErrors(tempErrors);

    return Object.values(tempErrors).every(x => x === "");
  };


  return (
    <div className="flex flex-col gap-4">
      <div>
        <h2 className="text-2xl font-bold">Create account</h2>
        <p>Already have an account? <Link className="underline" href="/login">Log in</Link></p>
      </div>
      <Input type="email" placeholder="Email" name="email" onChange={handleChange} error={errors.email}/>
      <Input type="email" placeholder="Confirm Email" name="confirmEmail" onChange={handleChange} error={errors.confirmEmail}/>
      <Input type="password" placeholder="Password" name="password" onChange={handleChange} error={errors.password}/>
      <div>
        <Input type="password" placeholder="Confirm password" name="confirmPassword" onChange={handleChange} error={errors.confirmPassword}/>
        <span className="text-sm">Password must have one capital letter, one special character and minimum 10 characters.</span>
      </div>
      <button
        className="inline-block px-4 py-2 text-main-white w-full bg-light-green rounded-xl"
        onClick={handleNext}>
        Continue
      </button>
    </div>
  );
};

export default RegisterStepOne;