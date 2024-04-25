'use client'

import { Inter } from "next/font/google";
import "./globals.css";
import "./global-icons.css";
import NavMenu from "@/components/nav-menu";
import Footer from "@/components/footer";
import {Toaster, toast} from 'sonner';
import {useStore} from "@/stores/user-store";
import {useEffect} from "react";

const inter = Inter({ subsets: ["latin"] });

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  const checkAuth = useStore((state) => state.checkAuth);

  useEffect(() => {
    checkAuth();
    console.log("Checking if authenticated")
  }, [checkAuth]);

  return (
    <html lang="en" className="bg-light-grey">
      <body className={`${inter.className} flex flex-col min-h-screen`}>
        <NavMenu/>
        <div className="max-w-screen-xl mx-auto flex-grow px-2 sm:px-10 md:px-16 lg:px-48">
          {children}
        </div>
        <Footer/>
        <Toaster richColors position="top-center"/>
      </body>
    </html>
  );
}