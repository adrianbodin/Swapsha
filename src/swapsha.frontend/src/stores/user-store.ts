import { create } from 'zustand'

type UserState = {
  isLoggedIn: boolean;
  id: string | null;
  name: string | null;
  setUser: (user: { isLoggedIn: boolean; id: string | null; name: string | null; }) => void;
};

//QUESTION Maybe add more properties?
export const useStore = create<UserState>((set) => ({
  isLoggedIn: false,
  id: null,
  name: null,
  setUser: (user) => set(() => ({ ...user })),
}));