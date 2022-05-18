<template>
  <ListBox>
    <div class="columns content-dev">
      <div class="column is-12">
        <h1>Cadastro</h1>
      </div>
    </div>
    <div class="columns content-dev">
      <div class="column is-12">
        <div
          class="is-flex is-align-items-center is-justify-content-space-between"
        >
          <section>
            <label for="txtNome"> <strong> Nome do usuário </strong> </label>
          </section>
        </div>
        <div class="is-flex is-align-items-center">
          <div class="field mt-2">
            <div class="control has-icons-left">
              <input
                class="input"
                type="text"
                placeholder="Digite seu nome de usuário"
              />
              <span class="icon is-left">
                <i class="fas fa-user"></i>
              </span>
            </div>
          </div>
        </div>

        <div
          class="is-flex is-align-items-center is-justify-content-space-between mt-4"
        >
          <section>
            <label for="txtPassword1"> <strong> Senha </strong></label>
          </section>
        </div>
        <div class="is-flex is-align-items-center">
          <div class="field mt-2">
            <div class="control has-icons-left">
              <input
                id="txtPassword1"
                class="input"
                type="password"
                placeholder="Digite sua senha"
              />
              <span class="icon is-left">
                <i class="fas fa-lock"></i>
              </span>
            </div>
          </div>
        </div>

        <div
          class="is-flex is-align-items-center is-justify-content-space-between mt-4"
        >
          <label for="txtPassword2"> <strong> Confirmar senha </strong> </label>
        </div>
        <div class="is-flex is-align-items-center">
          <div class="field mt-2">
            <div class="control has-icons-left">
              <input
                id="txtPassword2"
                class="input"
                type="password"
                placeholder="Digite sua senha novamente"
              />
              <span class="icon is-left">
                <i class="fas fa-lock"></i>
              </span>
            </div>
          </div>
        </div>
      </div>
    </div>

    <ButtonsRegister />
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "../Listas/ListBox.vue";
import ButtonsRegister from "../Utils/ButtonsRegister.vue";
export default defineComponent({
  name: "DevRegister",
  components: { ListBox, ButtonsRegister },
});
</script>

<style scoped>
.box {
  margin: 2em 25em 10em;
  height: 40em;
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

.input, .textarea{
  width: 25em;
}
</style>
