<template>
  <ListBox>
    <div class="title">Cadastro</div>
    <form action="#">
      <div class="input-boxes">
        <div class="text is-justify-content-center">
          Para verificarmos que você é quem diz que é, mandaremos um e-mail de confirmação para que prossiga com o cadastro!
        </div>
        <div class="input-box">
          <i class="fas fa-envelope"></i>
          <input type="text" placeholder="Seu Email" required />
        </div>
        <div class="button input-box">
          <ButtonsRegister @click="avancarPagina">Enviar</ButtonsRegister>
        </div>
      </div>
    </form>
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "../Listas/ListBox.vue";
import ButtonsRegister from "../Utils/ButtonsRegister.vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "DevEmail",
  components: { ListBox, ButtonsRegister },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "Credentials" });
    },
  },
});
</script>

<style scoped>
.box {
  margin: 2em 25em 10em;
  height: 25em;
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
