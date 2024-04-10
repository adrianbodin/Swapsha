'use client'

import React, {useState} from 'react';
import Image from 'next/image';
import Link from "next/link";


//TODO: Refactor this into smaller parts
const NavMenu = () => {
  const [expanded, setExpanded] = useState(false);

  function toggleExpand(){
    setExpanded(!expanded)
  }

  function collapseNav(){
    setExpanded(false)
  }
  return (
    <div className="fixed overflow-auto z-50 bottom-0 sm:top-1/3 sm:left-0 flex w-full sm:w-auto flex-col items-center gap-2">
      <nav className="rounded-r-lg px-3 py-4 bg-main-white flex w-full sm:w-auto justify-evenly flex-row sm:flex-col gap-3">
        <Link className="flex gap-3" onClick={collapseNav} href="/">
          <Image
            src="/S-logo.svg"
            alt="Swapsha logo svg"
            width={24}
            height={24}
          />
          {expanded && <span className="hover:underline">Home</span>}
        </Link>
        <Link className="flex gap-3" onClick={collapseNav} href="/users">
        <span className="material-symbols-outlined">
          groups
        </span>
          {expanded && <span className="hover:underline">Browse Users</span>}
        </Link>
        <hr className="hidden sm:block" />
        <Link className="flex gap-3" onClick={collapseNav} href="/register">
        <span className="material-symbols-outlined">
          edit_note
        </span>
          {expanded && <span className="hover:underline">Register</span>}
        </Link>
        <Link className="flex gap-3" onClick={collapseNav} href="/login">
          <span className="material-symbols-outlined">
            login
          </span>
          {expanded && <span className="hover:underline">Login</span>}
        </Link>
      </nav>
      <button onClick={toggleExpand} className="bg-main-white hidden sm:flex rounded-full w-8 h-8 items-center justify-center">
        {!expanded && <span className="material-symbols-outlined">arrow_forward</span>}
        {expanded && <span className="material-symbols-outlined">arrow_back</span>}
      </button>
    </div>
  );
};

export default NavMenu;