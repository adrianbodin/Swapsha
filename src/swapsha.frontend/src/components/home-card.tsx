import React, {FC} from 'react';
import Image from "next/image";

interface HomeCardProps{
  src: string;
  alt: string;
  title: string;
}

const HomeCard:FC<HomeCardProps> = ({ src, alt, title }) => {
  return (
    <div className="bg-main-white rounded-2xl shadow-2xl w-full">
      <p className="text-2xl font-bold mb-2 h-20 pt-2">{title}</p>
      <div>
        <Image
          src={src}
          alt={alt}
          width={640}
          height={427}
          className="rounded-b-2xl h-auto"
        />
      </div>
    </div>
  );
};

export default HomeCard;