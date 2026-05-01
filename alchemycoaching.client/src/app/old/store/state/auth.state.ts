import { User } from '../../services/auth-service';

export interface AuthState {
  user: User | null;
  role: string | null;
  loading: boolean;
  error: unknown | null;
}

export const initialAuthState: AuthState = {
  user: null,
  role: null,
  loading: false,
  error: null
};
