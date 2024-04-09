import Image from "next/image";
import Link from "next/link";
import {Main} from "next/document";
import Hero from "@/components/hero";

export default function Home() {
  return (
    <main className="flex flex-col items-center">
      <Image
        className="mt-10"
        src="/Swapsha-logo.svg"
        alt="Swapsha logo homescreen"
        height={0}
        width={300}
      />
      <Hero/>
    </main>
  );
}