import React, {FC, useState} from 'react';

interface InputProps {
  type: string;
  placeholder: string;
  error?: string;
  onChange?: (e:React.ChangeEvent<HTMLInputElement>) => void;
  name: string;
}

const Input: FC<InputProps> = ({ type, placeholder, error, onChange, name }) => {
  const [localError, setLocalError] = useState(error);
  const [isFocused, setIsFocused] = useState(false);

  const handleFocus = () => {
    setLocalError('');
    setIsFocused(true);
  };

  const handleBlur = () => {
    setIsFocused(false);
  };

  return (
    <div className="flex flex-col">
      {localError && <span className="text-sm text-red-500">{localError}</span>}
      <input
        type={type}
        name={name}
        placeholder={placeholder}
        onFocus={handleFocus}
        onBlur={handleBlur}
        onChange={onChange}
        className={`p-2 rounded ${localError && !isFocused ? 'border-red-500' : 'border-light-grey' } border-2`}/>
    </div>
  );
};

export default Input;