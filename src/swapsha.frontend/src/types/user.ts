export interface User {
  userId: string;
  email: string;
  fullName: string;
  profilePictureUrl: string | null;
  totalReviews: number | null;
  averageRating: number | null;
  skills: string[];
}