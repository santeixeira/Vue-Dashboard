<template>
  <ListBox>
    <div class="forms content">
      <div class="form-content">
        <div class="login-form">
          <div class="title">Login</div>
          <form action="#">
            <div class="input-boxes">
              <div class="input-box">
                <i class="fas fa-envelope"></i>
                <input type="text" placeholder="Digite o seu e-mail" required />
              </div>
              <div class="input-box">
                <i class="fas fa-lock"></i>
                <input
                  type="password"
                  placeholder="Digite sua senha"
                  required
                />
              </div>
              <div class="text">
                <router-link to="/forgot-password" class="link"
                  >Esqueceu a Senha?</router-link
                >
              </div>
              <div class="button input-box">
                <ButtonsRegister @click="avancarDashboard">Entrar</ButtonsRegister>
              </div>
              <div class="text sign-up-text">
                Não Possui uma Conta?
                <router-link to="/register/email" class="link"
                  >Cadastre-se</router-link
                >
              </div>
            </div>
          </form>
        </div>
      </div>
    </div>
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "@/components/Listas/ListBox.vue";
import ButtonsRegister from "@/components/Utils/ButtonsRegister.vue";
import ILogin from "@/interface/ILogin"
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Login",
  components: { ListBox, ButtonsRegister },
  data() {
    return {
      login: [] as ILogin[]
    }
  },
  methods: {
    avancarDashboard(){
      this.$router.push({ name: "DashBoard"})
    },
  }
});
</script>

<style lang="scss">
@import url("@/pages/Register/Primary.scss");
</style>
