'use client'
import UserCard from "@/components/user-card";
import LoadingSpinner from "@/components/loading-spinner";
import {useFetchUsers} from "@/hooks/useFetchUsers";

const UserPage = () => {
  const {state, handleSkillChange, handleSortChange, nextPage, previousPage} = useFetchUsers()

  const totalPages = Math.ceil(state.pageInfo.totalRecords / state.pageInfo.pageSize);

  return (
    <section className="mt-10 mb-40">
      <h2 className="text-center text-2xl mb-10 font-bold">Lets find the best match for your project!</h2>
      <div className="flex gap-10">
        <div>
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
        </div>
        <div>
          <label className="font-bold" htmlFor="skill-select">Sort by</label>
          <select className="p-2 rounded-md block"
                  name="skill-select"
                  id="skill-select"
                  onChange={handleSortChange}>
            <option value="best-rating">Best Rating</option>
            <option value="most-ratings">Most Ratings</option>
          </select>
        </div>
      </div>
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
      <div className="flex justify-center pt-10">
        <div className="flex">
          <button
            disabled={state.pageInfo.pageIndex === 1}
            onClick={previousPage}
            className={state.pageInfo.pageIndex === 1 ? `opacity-25` : `opacity-100`}>
            <span className="material-symbols-outlined">
              arrow_back_ios
            </span>
          </button>
          <span className="pr-1">Page {state.pageInfo.pageIndex} of {totalPages}</span>
          <button
            disabled={state.pageInfo.pageIndex === totalPages}
            className={state.pageInfo.pageIndex === totalPages ? `opacity-25` : `opacity-100`}
            onClick={nextPage}>
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