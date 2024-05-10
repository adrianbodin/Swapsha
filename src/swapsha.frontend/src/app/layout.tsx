'use client'

import { Inter } from "next/font/google";
import "./globals.css";
import "./global-icons.css";
import NavMenu from "@/components/nav-menu";
import Footer from "@/components/footer";
import {Toaster} from 'sonner';
import {useStore} from "@/stores/user-store";
import {useEffect} from "react";
import { QueryClient, QueryClientProvider } from "react-query";

const inter = Inter({ subsets: ["latin"] });

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  const checkAuth = useStore((state) => state.checkAuth);

  //for react query
  const queryClient = new QueryClient();

  useEffect(() => {
    checkAuth();
    console.log("Checking if authenticated")
  }, [checkAuth]);

  return (
    <html lang="en" className="bg-light-grey">
      <body className={`${inter.className} flex flex-col items-center`}>
        <QueryClientProvider client={queryClient}>
          <NavMenu/>
          <div className="max-w-screen-xl min-h-screen px-2 sm:px-10 md:px-16 lg:px-48">
            {children}
          </div>
          <Footer/>
          <Toaster richColors position="top-center"/>
        </QueryClientProvider>
      </body>
    </html>
  );
}