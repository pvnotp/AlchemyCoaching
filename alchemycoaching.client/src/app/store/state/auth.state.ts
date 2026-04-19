import { User } from '../../services/account-service';

export interface AuthState {
  user: User | null;
  loading: boolean;
  error: unknown | null;
}

export const initialAuthState: AuthState = {
  user: null,
  loading: false,
  error: null
};
