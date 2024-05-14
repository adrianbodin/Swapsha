interface Skill{
  id: number;
  name: string;
}

interface SubSkill{
  id: number;
  name: string;
}

export interface FullSkill{
  id: number;
  name: string;
  subSkills: SubSkill[];
}