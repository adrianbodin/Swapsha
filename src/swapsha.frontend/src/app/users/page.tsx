'use client'
import UserCard from "@/components/user-card";
import LoadingSpinner from "@/components/loading-spinner";
import {useFetchUsers} from "@/hooks/useFetchUsers";

const UserPage = () => {
  const {state, handleSkillChange} = useFetchUsers()

  return (
    <section className="mt-10 mb-40">
      <h2 className="text-center text-2xl mb-10 font-bold">Lets find the best match for your project!</h2>
      <label className="font-bold" htmlFor="skill-select">Filter by skill</label>
      <select className="p-2 rounded-md block"
                name="skill-select"
                id="skill-select"
                onChange={handleSkillChange}>
        <option value="">All</option>
          {state.skills && state.skills.map((skill) =>
            <option key={skill.id} value={skill.name}>{skill.name}</option>)}
      </select>
      <p className="text-dark-grey mt-2"><span className="font-bold underline">{state.pageInfo.totalRecords}</span> users</p>
      {state.loading &&
          <div className="flex justify-center items-center h-dvh">
              <LoadingSpinner />
          </div>}
      {state.error &&
          <div className="flex justify-center items-center h-dvh">
              <h3 className="underline font-bold text-2xl">Error, please try again later.</h3>
          </div>}
      {state.users.length === 0 &&
          <div className="flex justify-center items-center h-dvh">
              <h3 className="underline font-bold text-2xl">There was no users found.</h3>
          </div>}
      <div className="grid grid-cols-1 gap-10 mt-2 md:grid-cols-2">
        {!state.loading && state.users.map(user =>
              <UserCard key={user.userId} user={user}/>
          )}
      </div>
    </section>
  );
};

export default UserPage;