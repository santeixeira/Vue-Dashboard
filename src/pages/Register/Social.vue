<template>
  <ListBox>
    <div class="forms content">
      <div class="form-content">
        <div class="login-form">
          <div class="title">Social</div>
          <form action="#">
            <span class="text">
              <strong>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Saepe
                necessitatibus labore excepturi corrupti.
              </strong>
            </span>
            <SelectRegister :icon="escolaridadeIcon">
              <option value="null" default>Selecione sua escolaridade</option>
              <option
                :value="index"
                v-for="(index, desc) in escolaridade"
                :key="desc"
              >
                {{ escolaridade[desc] }}
              </option></SelectRegister
            >

            <SelectRegister :icon="cursouIcon">
              <option value="null" default>
                Selecione tipo de escola onde cursou
              </option>
              <option
                :value="index"
                v-for="(index, desc) in cursou"
                :key="desc"
              >
                {{ cursou[desc] }}
              </option>
            </SelectRegister>
            <SelectRegister :icon="cursoInglesIcon">
              <option value="null" default>
                Selecione quantos anos frequentou curso de inglês
              </option>
              <option value="Nenhum">Nenhum</option>
              <option value="1">1 ano</option>
              <option value="2">2 anos</option>
              <option value="3">3 anos</option>
              <option value="4">4 anos</option>
            </SelectRegister>
            <SelectRegister :icon="stHabitacionalIcon">
              <option value="null" default>
                Selecione qual a sua situação habitacional
              </option>
              <option value="Masculino">Própria</option>
              <option value="Feminino">Alugada</option>
              <option value="Cedida">Cedida</option>
              <option value="Outra">Outra</option>
            </SelectRegister>
            <div class="is-flex is-justify-content-space-between">
              <SelectRegister :icon="familyIcon">
                <option value="null" default>Renda familiar</option>
                <option value="Ate 1 SM">Até 1 Salário Mínimo</option>
                <option value="1 a 2 SM">1 a 2 Salários Mínimos</option>
                <option value="2 a 3 SM">2 a 3 Salários Mínimos</option>
                <option value="3 a 4 SM">3 a 4 Salários Mínimos</option>
                <option value="Mais de 4 SM">Mais de 4 Salários Mínimos</option>
              </SelectRegister>
              <SelectRegister :icon="nucleoIcon">
                <option value="null" default>Núcleo familiar</option>
                <option value="Masculino">Ele</option>
                <option value="Feminino">Ela</option>
                <option value="Outro">Outro</option>
              </SelectRegister>
            </div>
          </form>
        </div>
      </div>
    </div>
    <div class="input-box is-flex button-space-between">
      <ButtonsRegister @click="voltarPagina" :class="btnAnterior"
        >Anterior</ButtonsRegister
      >
      <ButtonsRegister @click="avancarPagina">Next</ButtonsRegister>
    </div>
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "@/components/Listas/ListBox.vue";
import ButtonsRegister from "@/components/Utils/ButtonsRegister.vue";
import SelectRegister from "@/components/Utils/SelectRegister.vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Social",
  components: {
    ListBox,
    ButtonsRegister,
    SelectRegister,
  },
  data() {
    return {
      escolaridade: [
        "Alfabetizado",
        "Ensino fundamental incompleto",
        "Ensino fundamental completo",
        "Ensino superior incompleto",
        "Ensino superior completo",
      ],
      escolaridadeIcon: "fas fa-graduation-cap",

      cursou: [
        "Todo em escola(s) pública(s)",
        "Todo em escola(s) priivada(s)",
        "Maior parte em escola pública",
        "Maior parte em escola privada",
      ],
      cursouIcon: "fas fa-school",
      cursoInglesIcon: "fas fa-language",
      stHabitacional: ["Propria", "Alugada", "Cedida", "Outra"],
      stHabitacionalIcon: "fas fa-house",
      family: ["Ate 1 SM", "1 a 2 SM", "2 a 3 SM", "3 a 4 SM", "Mais de 4 SM"],
      familyIcon: "fas fa-people-roof",
      nucleo: [1, 2, 3, 4, 5, 6],
      nucleoIcon: "fas fa-house-user",
      btnAnterior: "anter",
    };
  },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "Completed" });
    },
    voltarPagina() {
      this.$router.push({ name: "Diversity" });
    },
  },
});
</script>

<style scoped>
@import url("Primary.scss");

.button-space-between {
  justify-content: space-between;
}
.box {
  margin: 2em 20em 10em;
  height: 45em;
}
.content-dev {
  margin: 0em 1em 0;
}
.title-dev {
  margin: 3em;
}

.input-box {
  margin: 0 0 2em !important;
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

.anter:hover {
  border: 2px solid #051c27;
  background: none;
  color: #051c27;
}
</style>
