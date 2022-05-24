/* eslint-disable vue/multi-word-component-names */
<template>
  <ListBox>
    <header>
      <div class="columns content-dev">
        <div class="column is-12">
          <h1>Cadastro</h1>
        </div>
      </div>
    </header>

    <form @submit.prevent="save">
      <section>
        <TextRegister
          :id="inputUsername"
          :placeholder="apelido"
          :icon="iconName"
          v-model="inputUsername"
          @keydown.space.prevent
        />
        <TextRegister :placeholder="senha" :icon="iconSenha" :type="password" />
        <TextRegister
          :id="inputPassword"
          :placeholder="confirmaSenha"
          :icon="iconSenha"
          v-model="inputPassword"
          type="password"
        />
      </section>
    </form>
    <footer>
      <div class="column has-text-right">
        <ButtonsRegister @click="avancarPagina">Next</ButtonsRegister>
      </div>
    </footer>
  </ListBox>
</template>

<script lang="ts">
import { computed } from "@vue/reactivity";
import { defineComponent } from "vue";
import { useStore } from "@/store";
import ListBox from "@/components/Listas/ListBox.vue";
import ButtonsRegister from "@/components/Utils/ButtonsRegister.vue";
import TextRegister from "@/components/Utils/TextRegister.vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Credencials",
  components: { ListBox, ButtonsRegister, TextRegister },
  props: {
    id: {
      type: String,
    },
  },
  mounted() {
    if (this.id) {
      const user = this.store.state.users.find(
        (user) => user.id == this.id
      );
      this.inputUsername = user?.username || "";
    }
  },
  data() {
    return {
      apelido: "Digite seu apelido",
      senha: "Digite uma senha",
      confirmaSenha: "Confirme uma senha",
      iconName: "fas fa-user",
      iconApelido: "fas fa-lock",
      iconSenha: "fas fa-lock",
      password: "password",
      inputUsername: "",
      inputPassword: "",
    };
  },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "Personal" });
    },
    save() {
      this.store.commit("ADD_USER", [this.inputUsername, this.inputPassword]);
      this.inputUsername = "";
      this.inputPassword = "";
    },
  },
  setup() {
    const store = useStore();
    return {
      store,
      users: computed(() => store.state.users),
    };
  },
});
</script>

<style lang="scss" scoped>
@import url("./Primary.scss");
.box {
  margin: 2em 25em 10em;
  height: 35em;
}
.content-dev {
  margin: 3em;
}

.progressbar li {
  float: left;
  width: 20%;
  position: relative;
  text-align: center;
}

.input::placeholder {
  font-size: small;
  font-weight: 700;
}

.input,
.textarea {
  width: 25em;
}
</style>
