interface Skill{
  id: number;
  name: string;
  subSkills: SubSkill[]
}

interface SubSkill{
  id: number;
  name: string;
}