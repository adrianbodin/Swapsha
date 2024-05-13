'use client'

import React, {useState} from 'react';
import Link from "next/link";
import Input from "@/components/input";
import {apiRoutes} from "@/api-routes";
import {toast} from "sonner";
import {useStore} from "@/stores/user-store";
import {useRouter} from "next/navigation";

interface LoginForm{
  email: string,
  password: string
}

const Page = () => {
  const setUser = useStore((state) => state.setUser);
  const router = useRouter()
  const [loginForm, setLoginForm] = useState<LoginForm>({
    email: '',
    password: ''
  })
  const [errors, setErrors] = useState<LoginForm>({
    email: '',
    password: ''
  })

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setLoginForm({
      ...loginForm,
      [e.target.name]: e.target.value
    });
  };

  const validate = () => {
    let tempErrors : LoginForm = {
      email: loginForm.email ? "" : "Email is required.",
      password: loginForm.password ? "" : "Password is required.",
    };

    if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(loginForm.email)) {
      tempErrors.email = "Email is not valid.";
    }

    if (loginForm.password.length < 8) {
      tempErrors.password = "Password must be at least 10 characters.";
    }

    if (!/[A-Z]/.test(loginForm.password)) {
      tempErrors.password = "Password must contain at least one capital letter.";
    }

    if (!/[!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?]/.test(loginForm.password)) {
      tempErrors.password = "Password must contain at least one special character.";
    }

    setErrors(tempErrors);

    return Object.values(tempErrors).every(x => x === "");
  };

  async function submitLogin(){
    if(validate()){
      try {
        const response = await fetch(apiRoutes.login, {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json'
          },
          body: JSON.stringify(loginForm),
          credentials: 'include'
        });

        if(!response.ok){
          throw new Error("Could not login, please try again.")
        }

        const profileResponse = await fetch(apiRoutes.profile, {
          credentials: 'include'
        });

        const userInfo = await profileResponse.json();

        setUser({
          isLoggedIn: true,
          id: userInfo.id,
          name: userInfo.firstName,
        });

        router.push('/users');

      } catch (error){
        if(error instanceof Error){
          setLoginForm({email:'', password:''});
          toast.error(error.message);
        }
      }
    }
  }

  return (
    <div className="h-screen flex items-center">
      <div className="flex flex-col gap-4">
        <div>
          <h2 className="text-2xl mb-2 font-bold">Login to your account</h2>
          <p>Dont have an account? <Link className="underline" href="/register">Register</Link></p>
        </div>
        <Input type="email" placeholder="Email" name="email" onChange={handleChange} error={errors.email}/>
        <Input type="password" placeholder="Password" name="password" onChange={handleChange} error={errors.password}/>
        <button
          className="inline-block px-4 py-2 text-main-white w-full bg-light-green rounded-xl"
          onClick={submitLogin}>
          Login
        </button>
      </div>
    </div>
  );
};

export default Page;