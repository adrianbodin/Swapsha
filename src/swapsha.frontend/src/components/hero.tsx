import React from 'react';
import Image from "next/image";
import Link from "next/link";

const Hero = () => {
  return (
    <section className="flex flex-col md:flex-row w-full items-center">
      <div className="mb-4 md:w-auto">
        <h1 className="text-5xl font-bold">Help Each Other.</h1>
        <hr className="h-px my-2 w-11/12 bg-dark-grey border-0"/>
        <h3 className="text-2xl my-3">
          For a better and more<br/>
          sustainable living.
        </h3>
        <Link href="/register">
          <button className="inline-block px-4 py-2 text-dark-black bg-light-green rounded-xl w-1/3">Register</button>
        </Link>
      </div>
      <div className="md:w-3/5">
        <Image
          src="/images/home-hero.jpg"
          className="rounded-2xl shadow-2xl"
          alt="Picture of happy people helping each other"
          width={1000}
          height={667}
        />
      </div>
    </section>
  );
};

export default Hero;