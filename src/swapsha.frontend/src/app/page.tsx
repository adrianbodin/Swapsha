import Image from "next/image";
import Link from "next/link";
import {Main} from "next/document";
import Hero from "@/components/hero";
import HomeCard from "@/components/home-card";

export default function Home() {
  return (
    <main className="flex flex-col items-center gap-40 sm:gap-0">
      <Image
        src="/Swapsha-logo.svg"
        alt="Swapsha logo homescreen"
        height={300}
        width={300}
        className="mt-10"
      />
      <section className=" sm:h-dvh flex flex-col justify-center items-center">
        <Hero/>
      </section>
      <section className="text-center mb-20 lg:mb-64">
        <h3 className="text-3xl font-bold underline mb-5 md:mb-14">Simple 3 step process</h3>
        <div className="flex flex-col md:flex-row gap-5 md:items-center">
          <HomeCard
            src="/images/home-page-signup.jpg"
            alt="We want you!"
            title="Sign up."
          />
          <span className="material-symbols-outlined text-7xl md:hidden">
            arrow_downward
          </span>
          <span className="material-symbols-outlined text-7xl hidden md:block">
            arrow_forward
          </span>
          <HomeCard
            src="/images/home-page-list-skills.jpg"
            alt="sitting by the computer"
            title="List your skills or services."
          />
          <span className="material-symbols-outlined text-7xl md:hidden">
            arrow_downward
          </span>
          <span className="material-symbols-outlined text-7xl hidden md:block">
            arrow_forward
          </span>
          <HomeCard
            src="/images/home-page-start-swaping.jpg"
            alt="Fistbumping"
            title="Start Swapping!"
          />
        </div>
      </section>
    </main>
  );
}