import {useEffect, useState} from 'react';
import {apiRoutes} from "@/api-routes";
import {toast} from "sonner";
import {useRouter} from "next/navigation";

interface RegisterFormData{
  email: string;
  password: string;
  firstName: string;
  middleName?: string;
  lastName: string;
  profilePicture?: File;
}

const UseRegister = () => {
  const [step, setStep] = useState(1);
  const router = useRouter();

  //This will hold the form data for registration
  const [formData, setFormData] = useState<RegisterFormData>({
    email: '',
    password: '',
    firstName: '',
    middleName: '',
    lastName: '',
    profilePicture: undefined
  });

  useEffect(() => {
    console.log(formData);
  }, [formData]);

  const nextStep = () => {
    setStep(prevStep => prevStep + 1);
  };

  const handleFormData = (newData: any) => {
    setFormData(prevData => ({
      ...prevData,
      ...newData
    }));
  };

  const submitRegisterForm = async () => {
    try{
      const registerResponse = await fetch(apiRoutes.register, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          email: formData.email,
          password: formData.password
        }),
        credentials: 'include'
      });

      if(!registerResponse.ok){
        throw new Error("There was an error registering the user");
      }

      //This will set a cookie with auth if it is successful
      const loginResponse = await fetch(apiRoutes.login, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          email: formData.email,
          password: formData.password
        }),
        credentials: 'include'
      });

      if(!loginResponse.ok){
        throw new Error("There was an error logging in the user after registration");
      }

      //is used to fetch the id of the user
      const profileResponse = await fetch(apiRoutes.profile, {
        credentials: 'include'
      });

      if(!profileResponse.ok){
        throw new Error("There was an error when getting the logged in users id");
      }

      const userId = await profileResponse.json()
      console.log(userId)

      const namesData: any = {
        firstName: formData.firstName,
        lastName: formData.lastName
      };

      if (formData.middleName) {
        namesData.middleName = formData.middleName;
      }

      const addNamesResponse = await fetch(`${apiRoutes.root}/users/${userId.id}/names`,{
        method: 'POST',
        body: JSON.stringify(namesData),
        credentials: 'include'
      });

      if(!addNamesResponse.ok){
        throw new Error("There was an error adding names to your profile");
      }

      // Create a new FormData instance
      const formDat = new FormData();

      // Append the profile picture file to the form data
      if (formData.profilePicture) {
          formDat.append('profilePicture', formData.profilePicture);
      }

      // Make the fetch request, passing the form data as the body
      const addProfilePicResponse = await fetch(`${apiRoutes.root}/users/${userId.id}/profilepic`, {
        method: 'POST',
        body: formDat,
        credentials: 'include'
      });

      if(!addProfilePicResponse.ok){
        throw new Error("There was an error adding the profile picture to your profile");
      }

      //should set the user to signed in and redirect

      router.push('/');

    }catch(error){
      if (error instanceof Error) {
        console.error(error);
        toast.error(error.message);
      }
    }
  }
  return {step, nextStep, handleFormData, submitRegisterForm};
};

export default UseRegister;