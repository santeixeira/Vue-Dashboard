<template>
  <ListBox>
    <div class="columns content-dev">
      <div class="column is-12">
        <h1>teste</h1>
      </div>
    </div>
    <div class="columns content-dev">
      <div class="column is-12">
        <div
          class="is-flex is-align-items-center is-justify-content-space-between"
        >
          <section>
            <label for="txtNome">
              <strong> Faça um pequeno resumo sobre você </strong>
            </label>
          </section>
        </div>
        <div class="is-flex is-align-items-center">
          <textarea
            class="textarea mt-2"
            placeholder="Digite seus objetivos como desenvolvedor"
          ></textarea>
        </div>

        <div
          class="is-flex is-align-items-center is-justify-content-space-between mt-4"
        >
          <section>
            <label for="txtNome">
              <strong> Defina o seu perfil profissional </strong>
            </label>
          </section>
        </div>
        <div class="is-flex is-align-items-center">
          <div class="field mt-2">
            <div class="control has-icons-left">
              <input
                class="input"
                type="text"
                placeholder="Digite como se entitula"
              />
              <span class="icon is-left">
                <i class="fas fa-address-card"></i>
              </span>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="column is-flex">
      <ButtonsRegister @click="voltarPagina">Anterior</ButtonsRegister>
      <ButtonsRegister @click="avancarPagina">Next</ButtonsRegister>
    </div>
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "../Listas/ListBox.vue";
import ButtonsRegister from "../Utils/ButtonsRegister.vue";
export default defineComponent({
  name: "DevSobre",
  components: { ListBox, ButtonsRegister },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "DevRegisterCarreira" });
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
  height: 40em;
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
