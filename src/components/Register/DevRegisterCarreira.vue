<template>
  <ListBox>
    <div class="columns title-dev">
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
    <div class="columns content-dev">
      <div class="column is-12">
        <div
          class="is-flex is-align-items-center is-justify-content-space-between"
        >
          <section>
            <label for="txtNome">
              <strong> Modalidade de trabalho desejada </strong>
            </label>
          </section>
        </div>
        <div class="is-flex is-align-items-center">
          <ul class="is-flex">
            <li>
              <label class="checkbox">
                <input type="checkbox" />
                Hibrido
              </label>
            </li>
            <li>
              <label class="checkbox">
                <input type="checkbox" />
                Presencial
              </label>
            </li>
            <li>
              <label class="checkbox">
                <input type="checkbox" />
                Remoto
              </label>
            </li>
          </ul>
        </div>
      </div>
    </div>
    <div class="column is-flex">
      <TextSalaryRegister>PJ</TextSalaryRegister>
      <TextSalaryRegister>CLT</TextSalaryRegister>
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
import TextSalaryRegister from "../Utils/TextSalaryRegister.vue";
export default defineComponent({
  name: "DevRegisterCarreira",
  components: { ListBox, ButtonsRegister, TextSalaryRegister },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "DevSobre" });
    },
    voltarPagina() {
      this.$router.push({ name: "DevRegister" });
    },
  },
});
</script>

<style scoped>
.box {
  margin: 2em 25em 10em;
  height: 50em;
}
.content-dev {
  margin: 0em 2em 0;
}
.title-dev {
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
.textarea,
select {
  width: 25em;
}

li {
  margin-right: 1.75em;
}

.anter {
  background-color: #051c27;
}
</style>
