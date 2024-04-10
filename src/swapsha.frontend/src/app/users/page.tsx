'use client'

import React, {useEffect, useState} from 'react';
import UserCard from "@/components/user-card";
import {User} from "@/types/user";
import {PageInfo} from "@/types/page-info";

const Page = () => {
  const [users, setUsers] = useState<User[]>([])
  const [pageInfo, setPageInfo] = useState<PageInfo>({
    pageIndex: 1,
    pageSize: 10,
    totalRecords: 0
  })

  //Function to fetch the users and set the state with the data
  async function fetchUsers(pageIndex: number){
    const result = await fetch(`https://localhost:7228/api/v1/users?pageIndex=${pageIndex}&pageSize=10`);
    const json = await result.json();

    setUsers(json.data);
    setPageInfo({
         pageIndex: json.pageIndex,
         pageSize: json.pageSize,
         totalRecords: json.totalRecords
       });
  }

  //This runs when the component is initialized
  useEffect(() => {
    fetchUsers(pageInfo.pageIndex)
  }, []);

  return (
    <section className="mt-10">
      <h2 className="text-center text-2xl font-bold">Lets find the best match for your project!</h2>
      <div className="grid grid-cols-1 gap-10 pt-10 md:grid-cols-2">
        {users.map(user =>
          <p key={user.userId}>{user.email}</p>
        )}
      </div>
    </section>
  );
};

export default Page;