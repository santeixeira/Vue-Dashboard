import ICredentials from "@/interface/ICredentials";
import { InjectionKey } from "vue";
import { createStore, Store } from "vuex";

interface State {
  credentials: ICredentials[];
}

export const key: InjectionKey<Store<State>> = Symbol();

export const store = createStore<State>({
  state: {
    credentials: [],
  },
  mutations: {
    'ADD_USER'(state, username: string) {
      const user = {
        username: username,
      } as ICredentials;
      state.credentials.push(user);
    },
  },
});
