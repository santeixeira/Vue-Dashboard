<template>
  <ListBox>
    <div class="columns content-dev">
      <div class="column is-12">
        <h1>Cadastro</h1>
      </div>
    </div>
    <form action="#">
      <TextRegister :placeholder="apelido" :icon="iconName"/>
      <TextRegister :placeholder="senha" :icon="iconSenha"/>
      <TextRegister :placeholder="confirmaSenha" :icon="iconSenha"/>
    </form>
    <div class="column has-text-right">
      <ButtonsRegister @click="avancarPagina">Next</ButtonsRegister>
    </div>
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "../Listas/ListBox.vue";
import ButtonsRegister from "../Utils/ButtonsRegister.vue";
import TextRegister from "../Utils/TextRegister.vue";
export default defineComponent({
  name: "DevRegister",
  components: { ListBox, ButtonsRegister, TextRegister },
  
  methods: {
    avancarPagina() {
      this.$router.push({ name: "DevRegisterCarreira" });
    },
  },
  data(){
    return {
      apelido: "Digite seu apelido",
      senha: "Digite uma senha",
      confirmaSenha: "Confirme uma senha",
      iconName: "fas fa-user",
      iconApelido: "fas fa-lock",
      iconSenha: "fas fa-lock",
    }
  }
});
</script>

<style scoped>
@import url("./Login.scss");
.box {
  margin: 2em 25em 10em;
  height: 35em;
}
.content-dev {
  margin: 3em;
}

.button {
  width: calc();
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
