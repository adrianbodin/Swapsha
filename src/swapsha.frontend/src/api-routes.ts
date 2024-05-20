export const apiRoutes = {
  root: 'https://localhost:7228/api/v1',
  register: 'https://localhost:7228/api/v1/identity/register',
  login: 'https://localhost:7228/api/v1/identity/login?useCookies=true',
  logout: 'https://localhost:7228/api/v1/identity/logout',
  profile: 'https://localhost:7228/api/v1/users/profile',
  users: 'https://localhost:7228/api/v1/users',
  pendingRequests: 'https://localhost:7228/api/v1/profile/contact-requests/pending',
  contacts: 'https://localhost:7228/api/v1/users/contacts'
}