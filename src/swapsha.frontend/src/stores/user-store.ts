import { create } from 'zustand'
import {apiRoutes} from "@/api-routes";

type UserState = {
  isLoggedIn: boolean;
  id: string | null;
  name: string | null;
  setUser: (user: { isLoggedIn: boolean; id: string | null; name: string | null; }) => void;
  checkAuth: () => void;
};

//QUESTION Maybe add more properties?
export const useStore = create<UserState>((set) => ({
  isLoggedIn: false,
  id: null,
  name: null,
  setUser: (user) => set(() => ({ ...user })),
  checkAuth: async () => {
    try {
      const response = await fetch(apiRoutes.profile, { credentials: 'include' });

      if (response.ok) {
        const user = await response.json();
        set({
          isLoggedIn: true,
          id: user.id,
          name: user.name,
        });
      } else {
        set({
          isLoggedIn: false,
          id: null,
          name: null,
        });
      }
    } catch (error) {
      console.error(error);
    }
  },
}));