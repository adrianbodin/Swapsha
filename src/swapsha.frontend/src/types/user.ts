import {Skill} from "@/types/skill";

export interface User {
  userId: string;
  email: string;
  firstName: string;
  lastName: string;
  profilePictureUrl: string | null;
  skills: Skill[]
  wantedSkills: Skill[]
}