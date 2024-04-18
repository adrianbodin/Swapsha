import React, {useState} from 'react';
import Input from "@/components/input";
import Link from "next/link";

const RegisterStepOne = () => {
  const [formData, setFormData] = useState({
    email: '',
    confirmEmail: '',
    password: '',
    confirmPassword: ''
  });
  const [errors, setErrors] = useState({});

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    });
  };

  return (
    <div className="flex flex-col gap-4">
      <div>
        <h2 className="text-2xl font-bold">Create account</h2>
        <p>Already have an account? <Link className="underline" href="/login">Log in</Link></p>
      </div>
      <Input type="email" placeholder="Email" name="email" onChange={handleChange}/>
      <Input type="email" placeholder="Confirm Email" name="confirmEmail" onChange={handleChange}/>
      <Input type="password" placeholder="Password" name="password" onChange={handleChange}/>
      <div>
        <Input type="password" placeholder="Confirm password" name="confirmPassword" onChange={handleChange}/>
        <span className="text-sm">Password must have one capital letter, one special character and minimum 10 characters.</span>
      </div>
      <button className="inline-block px-4 py-2 text-main-white w-full bg-light-green rounded-xl">Continue</button>
    </div>
  );
};

export default RegisterStepOne;