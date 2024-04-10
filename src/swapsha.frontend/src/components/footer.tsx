import React from 'react';
import Image from "next/image";
import Link from "next/link";

const Footer = () => {
  return (
    <footer className="flex flex-col items-center justify-center pb-16 sm:pb-5">
      <div className="flex w-full justify-evenly pb-5">
        <div className="hidden md:block">
          <Link href="/">
            <Image
              src="/S-logo.svg"
              alt="Swapsha logo svg"
              width={100}
              height={100}
            />
          </Link>
        </div>
        <div className="text-center hidden sm:block">
          <h4 className="underline font-bold">Follow us!</h4>
          <h3>
            <a href="https://www.facebook.com/" target="_blank">Facebook </a>
            |
            <a href="https://www.tiktok.com/sv-SE/" target="_blank"> TikTok</a>
          </h3>
        </div>
        <div className="flex flex-col gap-1">
          <h4 className="font-bold text-xl">Need help?</h4>
          <hr className="h-px w-11/12 bg-dark-grey border-0"/>
          <h3 className="flex items-center">
            <span className="material-symbols-outlined">call</span>
            <span>048833-48831</span>
          </h3>
          <h3 className="flex items-center">
            <span className="material-symbols-outlined">mail</span>
            <a href="mailto:swapsha@support.com">swapsha@support.com</a>
          </h3>
        </div>
      </div>
      <hr className="h-px my-2 w-11/12 bg-dark-grey border-0"/>
      <h6>2024 © Swapsha AB | All rights reserved </h6>
    </footer>
  );
};

export default Footer;