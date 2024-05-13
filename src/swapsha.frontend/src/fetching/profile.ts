import {SingleUser} from "@/types/user";
import {apiRoutes} from "@/api-routes";

export async function getProfileInfo(): Promise<SingleUser> {
  return fetch(apiRoutes.profile)
    .then(res => {
      if (!res.ok) {
        //QUESTION is this safe to write out.
        console.error("Error fetching profile", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error fetching the profile, we are sorry for the inconvenience.`)
      }
      return res.json();
    });
}