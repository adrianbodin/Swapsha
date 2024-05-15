import React, {FC, useState} from 'react';
import Input from "@/components/input";

type Name = 'firstname' | 'lastname' | 'middlename'

interface Props{
  name: string;
  nameType: Name;
}

const EditName:FC<Props> = ({ name, nameType }) => {
  const [disabledInput, setDisabledInput] = useState(true);

  return (
    <div className="flex gap-2 flex-grow">
      <Input disabled={disabledInput} type="text" data={name} name={nameType} placeholder={nameType}></Input>
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
          onClick={() => setDisabledInput(false)}>
          <span className="material-symbols-outlined">check</span>
        </button>
        <button
          className="shadow-gray-400 shadow-md bg-red-600 rounded-md w-1/8 h-10 w-10 flex justify-center items-center"
          onClick={() => setDisabledInput(true)}>
          <span className="material-symbols-outlined">close</span>
        </button>
        </>
      )}
    </div>
  );
};

export default EditName;