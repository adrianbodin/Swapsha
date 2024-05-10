import React, {FC} from 'react';
import {SingleUser} from "@/types/user";

type UserBioProps = Pick<SingleUser, 'skills' | 'wantedSkills' | 'bio'>;

const UserBio:FC<UserBioProps> = ( { skills, wantedSkills, bio } ) => {
  return (
    <section>
      <div className="my-10">
        {bio && <p>{bio}</p>}
      </div>
      <div className="mb-10">
        <h3 className="font-bold text-2xl mb-2">I am good at:</h3>
        <ul className="ml-5">
          {skills && skills.map(skill =>
            <li className="list-disc text-xl" key={skill.id} >{skill.name}</li>
          )}
        </ul>
      </div>
      <div className="mb-10">
        <h3 className="font-bold text-2xl mb-2">I am looking for:</h3>
        <ul className="ml-5">
          {wantedSkills && wantedSkills.map(wantedSkill =>
            <li className="list-disc text-xl" key={wantedSkill.id} >{wantedSkill.name}</li>)}
        </ul>
      </div>
    </section>
  );
};

export default UserBio;