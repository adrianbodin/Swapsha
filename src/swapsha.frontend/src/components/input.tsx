﻿import React, {FC, useState} from 'react';

interface InputProps {
  type: string;
  placeholder: string;
  error?: string;
  onChange?: (e:React.ChangeEvent<HTMLInputElement>) => void;
  name: string;
  data?: string;
  disabled?: boolean
}

const Input: FC<InputProps> = ({ type, placeholder, error, onChange, name, disabled, data }) => {

  return (
    <div className="flex flex-col">
      {error && <span className="text-sm text-red-500">{error}</span>}
      <input
        disabled={disabled}
        type={type}
        name={name}
        value={data}
        placeholder={placeholder}
        onChange={onChange}
        className={`p-2 rounded ${error ? 'border-red-500' : 'border-light-grey' } border-2`}/>
    </div>
  );
};

export default Input;