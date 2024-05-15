import React, {FC, useState} from 'react';
import Input from "@/components/input";
import {useMutation, useQueryClient} from "@tanstack/react-query";
import {updateFirstName, updateLastName, updateMiddleName} from "@/fetching/users";
import {validateName} from "@/helpers/validate-name";
import {toast} from "sonner";

type Name = 'firstname' | 'lastname' | 'middlename'

interface Props{
  name: string;
  nameType: Name;
  userId: string;
}

const EditName:FC<Props> = ({ name, nameType, userId }) => {
  const [disabledInput, setDisabledInput] = useState(true);
  const [nameInput, setNameInput] = useState(name);
  const [errorMessage, setErrorMessage] = useState<string>("")
  const queryClient = useQueryClient();
  const updateFunctions = {
    firstname: updateFirstName,
    middlename: updateMiddleName,
    lastname: updateLastName
  };


  const mutation = useMutation({
    mutationFn: (name: string) => {
      return updateFunctions[nameType](userId, name)
    },
    onSuccess: () => {
      console.log("hello")
      queryClient.invalidateQueries({ queryKey: ['profile', userId] });
      toast.success(`The ${nameType} was successfully updated`);
      setDisabledInput(true);
    },
    onError: () => {
      console.log("oooo")
      toast.error(`There was an error updating the ${nameType}`)
    }
  })

  async function handleSubmit(){
    const result = validateName(nameInput);
    if(result){
      setErrorMessage(result);
    } else {
      setErrorMessage('');
      mutation.mutate(nameInput);
    }
  }


  return (
    <div className="flex items-end gap-2 flex-grow">
      <Input
        disabled={disabledInput}
        error={errorMessage}
        onChange={(e) => setNameInput(e.target.value)}
        type="text"
        onFocus={() => setErrorMessage('')}
        onBlur={() => setErrorMessage('')}
        data={nameInput}
        name={nameType}
        placeholder={nameType}/>
      <div className="flex gap-2 mb-0.5">
        {disabledInput ? (
          <button
            className="shadow-gray-400 shadow-md bg-main-white rounded-md w-1/8 h-10 w-10 flex justify-center items-center"
            onClick={() => setDisabledInput(false)}>
            <span className="material-symbols-outlined">edit</span>
          </button>
        ) : (
          <>
            <button
              className="shadow-gray-400 shadow-md bg-green-600 rounded-md w-1/8 h-10 w-10 flex justify-center items-center"
              onClick={handleSubmit}>
              <span className="material-symbols-outlined">check</span>
            </button>
            <button
              className="shadow-gray-400 shadow-md bg-red-600 rounded-md w-1/8 h-10 w-10 flex justify-center items-center"
              onClick={() => {
                setDisabledInput(true);
                setNameInput(name);
                setErrorMessage('');
              }}>
              <span className="material-symbols-outlined">close</span>
            </button>
          </>
        )}
      </div>
    </div>
  );
};

export default EditName;