import React from 'react';
import Link from "next/link";

const Page = () => {
  return (
    <div>
      <Link href="/profile/account">
        Account
      </Link>
      <Link href="/profile/edit">
        Edit
      </Link>
      <Link href="/profile/contacts">
        Contacts
      </Link>
    </div>
  );
};

export default Page;