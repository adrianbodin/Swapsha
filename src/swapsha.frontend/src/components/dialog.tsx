import React, { FC, ReactNode, useEffect, useRef } from 'react';

interface DialogProps {
  children: ReactNode;
  onYes: () => void;
  onNo: () => void;
}

const Dialog: FC<DialogProps> = ({ children, onYes, onNo }) => {
  const dialog = useRef<HTMLDialogElement | null>(null);

  const handleYes = () => {
    dialog.current?.close();
    onYes();
  }

  const handleNo = () => {
    dialog.current?.close();
    onNo();
  }

  useEffect(() => {
    dialog.current?.showModal();
  }, []);

  return (
    <dialog
      className="w-full max-w-screen-md border-0 rounded-lg min-h-80 backdrop:bg-black/50 backdrop:backdrop-blur-md justify-between gap-6 p-10 flex flex-col items-center"
      ref={dialog}>
      <div className="flex flex-col items-center gap-4 w-full">
        {children}
      </div>
      <div className="flex w-full gap-5">
        <button
          onClick={handleYes}
          className="basis-1/2 px-4 py-2 bg-green-600 text-xl font-bold rounded-xl text-main-white shadow-sm shadow-black">
          Yes
        </button>
        <button
          onClick={handleNo}
          className="basis-1/2 px-4 py-2 bg-red-600 text-xl font-bold rounded-xl text-main-white shadow-sm shadow-black">
          No
        </button>
      </div>
    </dialog>
  );
};

export default Dialog;