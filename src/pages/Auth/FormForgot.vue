<template>
  <ListBox>
    <div class="title">Esqueci a senha</div>
    <form>
      <div class="input-boxes">
        <div class="text is-justify-content-center">
          Lorem ipsum dolor, sit amet consectetur adipisicing elit. Quos ipsam
          vitae quisquam obcaecati maiores natus!
        </div>
        <div class="input-box">
          <i class="fas fa-envelope"></i>
          <input type="text" placeholder="Seu Email" v-model="form.email" @keyup.enter="forgotPassword" required />
        </div>
        <div class="button input-box">
          <ButtonsRegister @click="forgotPassword">Enviar</ButtonsRegister>
        </div>
      </div>
    </form>
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "@/components/Listas/ListBox.vue";
import ButtonsRegister from "@/components/Utils/ButtonsRegister.vue";
import {client} from "@/http"
interface Email {
  email: string
}
export default defineComponent({
  name: "FormForgot",
  components: { ListBox, ButtonsRegister },
  data() {
    return {
      user: [] as Email[],
      form: {
        email: "",
      }
    }
  },
  methods: {
    forgotPassword() {
      alert(this.form.email)
      this.$router.push({ name: "MessageForgot" });
    },
    voltarPagina() {
      this.$router.push({ name: "DevRegisterCarreira" });
    },
  },
});
</script>

<style scoped>
.box {
  margin: 2em 25em 10em;
  height: 25em;
}

.text {
  text-align: justify;
  margin: 2em;
}
.content-dev {
  margin: 2em;
}

.progressbar li {
  float: left;
  width: 20%;
  position: relative;
  text-align: center;
}

.input::placeholder,
.textarea::placeholder {
  font-size: small;
  font-weight: 700;
}

.input,
.textarea,
select {
  width: 24em;
}

li {
  margin-right: 1.75em;
}

.anter {
  background-color: #051c27;
}
</style>
