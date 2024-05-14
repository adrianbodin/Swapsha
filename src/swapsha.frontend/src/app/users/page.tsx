'use client'
import UserCard from "@/components/user-card";
import LoadingSpinner from "@/components/loading-spinner";
import {keepPreviousData, useQuery} from "@tanstack/react-query";
import {getAllUsers} from "@/fetching/users";
import {useState} from "react";
import {getAllSkills} from "@/fetching/skills";

interface AllUsersState{
  page: number;
  sortBy: string;
  skillId?: number;
}

const UserPage = () => {
  const [state, setState] = useState<AllUsersState>({
    page: 1,
    sortBy: "best-rating",
    skillId: undefined
  })

  const {data, isError, isLoading} = useQuery({
    queryKey: ['users', state.page, state.sortBy, state.skillId],
    queryFn: () => getAllUsers(state.page, state.sortBy, state.skillId),
    placeholderData: keepPreviousData,
  });

  const { data: skills } = useQuery({
    queryKey: ['skills'],
    queryFn: () => getAllSkills()
  });

  const { data: users, pageIndex, pageSize, totalRecords } = data || {};

  const totalPages = Math.ceil((totalRecords ?? 1) / (pageSize ?? 1));

  return (
    <section className="mt-10 mb-40">
      <h2 className="text-center text-2xl mb-10 font-bold">Lets find the best match for your project!</h2>
      <div className="flex gap-10">
        <div>
          <label className="font-bold" htmlFor="skill-select">Filter by skill</label>
          <select className="p-2 rounded-md block"
                  name="skill-select"
                  id="skill-select"
                  onChange={(e) => {
                    if(skills) {
                      const chosenSkill = skills.find(skill => skill.name === e.target.value);
                      setState({...state, skillId: chosenSkill?.id})
                    }}}>
            <option value="">All</option>
            {skills && skills.map((skill) =>
              <option key={skill.id} value={skill.name}>{skill.name}</option>)}
          </select>
          <p className="text-dark-grey mt-2"><span className="font-bold underline">{totalRecords}</span> users</p>
        </div>
        <div>
          <label className="font-bold" htmlFor="skill-select">Sort by</label>
          <select className="p-2 rounded-md block"
                  name="skill-select"
                  id="skill-select"
                  onChange={(e) => setState({...state, sortBy: e.target.value})}>
            <option value="best-rating">Best Rating</option>
            <option value="most-ratings">Most Ratings</option>
          </select>
        </div>
      </div>
      {isLoading &&
        <div className="flex justify-center items-center h-dvh">
        <LoadingSpinner />
        </div>
      }
      {isError &&
          <div className="flex justify-center items-center h-dvh">
              <h3 className="underline font-bold text-2xl">Error, please try again later.</h3>
          </div>}
      {users && users.length === 0 &&
          <div className="flex justify-center items-center h-dvh">
              <h3 className="underline font-bold text-2xl">There was no users found.</h3>
          </div>}
      <div className="grid grid-cols-1 gap-10 mt-2 md:grid-cols-2">
        {users && users.map(user =>
              <UserCard key={user.userId} user={user}/>
          )}
      </div>
      <div className="flex justify-center pt-10">
        <div className="flex">
          <button
            disabled={pageIndex === 1}
            onClick={() => {
              setState(prevState => ({...prevState, page: prevState.page - 1}));
              window.scrollTo(0, 0);}}
            className={pageIndex === 1 ? `opacity-25` : `opacity-100`}>
            <span className="material-symbols-outlined">
              arrow_back_ios
            </span>
          </button>
          <span className="pr-1">Page {pageIndex} of {totalPages}</span>
          <button
            disabled={pageIndex === totalPages}
            className={pageIndex === totalPages ? `opacity-25` : `opacity-100`}
            onClick={() => {
              setState(prevState => ({...prevState, page: prevState.page + 1}));
              window.scrollTo(0, 0);
            }}>
            <span className="material-symbols-outlined">
              arrow_forward_ios
            </span>
          </button>
        </div>
      </div>
    </section>
  );
};

export default UserPage;