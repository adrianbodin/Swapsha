import {User} from "@/types/user";
import {apiRoutes} from "@/api-routes";

export async function fetchUserById(id: string): Promise<User> {
  return fetch(`${apiRoutes.root}/users/${id}`)
    .then(res => {
      if (!res.ok) {
        throw new Error(`HTTP error, status = ${res.status}`);
      }
      return res.json();
    });
}