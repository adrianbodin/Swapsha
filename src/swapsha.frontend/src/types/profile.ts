import {Skill} from "@/types/skills";

export interface Profile{
  id: string;
  firstName: string;
  middleName?: string;
  lastName: string;
  profilePicUrl: string;
  city: string;
  skills: Skill[];
  wantedSkills: Skill[];
}