import {toast} from "sonner";
import {FullSkill} from "@/types/skills";

export async function getAllSkills() : Promise<FullSkill[]>{
  try {
    return fetch(`https://localhost:7228/api/v1/skills`)
      .then(res => {
        if(!res.ok){
          throw new Error("There was an error fetching the skills for the filters")
        }
        return res.json()
      })
  }
  catch (error){
    toast.error("There was an error fetching the skills for the filters");
    return Promise.reject(error);
  }
}