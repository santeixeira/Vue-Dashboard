import { ICredentials, ILogin } from "@/interface/index";
import { InjectionKey } from "vue";
import { createStore, Store, useStore as vuexUseStore } from "vuex";
import { POST_LOGIN } from "./typeAction";
import { LOGIN, LOGOUT } from "./typeMutation";
import { client } from "@/http";

interface State {
  users: ICredentials[];
  login: ILogin[];
}

export const key: InjectionKey<Store<State>> = Symbol();

export const store = createStore<State>({
  state: {
    users: [],
    login: [],
  },
  mutations: {
    [LOGIN](state, email: string) {
      const userAccess = {
        email: email,
      } as ILogin;
      state.login.push(userAccess);
    },
    [LOGOUT](state, email: string) {
      state.login = state.login.filter((user) => user.email != email);
    },
  },
  actions: {
    async [POST_LOGIN]({ commit }) {
      await client.post("https://jobi-api.herokuapp.com/login");
    },
  },
});

export function useStore(): Store<State> {
  return vuexUseStore(key);
}
