<template>
  <ListBox>
    <div class="forms content">
      <div class="form-content">
        <div class="login-form">
          <div class="title">Pessoal</div>
          <form action="#">
            <TextRegister :placeholder="nome" :icon="iconTitulacao" />
            <SelectRegister></SelectRegister>
              <TextRegister :placeholder="genero" :icon="iconTitulacao" />
              <TextRegister :placeholder="etnia" :icon="iconTitulacao" />
              <TextRegister :placeholder="pcd" :icon="iconTitulacao" />
          </form>
        </div>
      </div>
    </div>
    <div class="input-box is-flex button-space-between">
      <ButtonsRegister @click="voltarPagina" :class="btnAnterior"
        >Anterior</ButtonsRegister>
      <ButtonsRegister @click="avancarPagina">Next</ButtonsRegister>
    </div>
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "../Listas/ListBox.vue";
import ButtonsRegister from "../Utils/ButtonsRegister.vue";
import TextRegister from "../Utils/TextRegister.vue";
import ITags from "@/interface/ITags";
import SelectRegister from "../Utils/SelectRegister.vue";
export default defineComponent({
  name: "DevRegisterCarreira",
  components: {
    ListBox,
    ButtonsRegister,
    TextRegister,
    SelectRegister,
  },
  data() {
    return {
      nome: "Digite o seu nome completo",
      github: "Digite seu github",
      genero: "Selecione o seu genero",
      etnia: "Selecione qual sua etnia",
      pcd: "Se você possui PCD, informe qual",
      modalidadeIcon: "fa-solid fa-house-laptop",
      iconTitulacao: "fas fa-brain",
      linkedIn: "Digite uma cidade de preferência",
      cidadeIcon: "fas fa-city",
      btnAnterior: "anter",
      modalidadeArray: ["Remoto", "Hibrido", "Presencial"],
      cidadeArray: [
        "Fortaleza",
        "Recife",
        "Salvador",
        "São Paulo",
        "Rio de Janeiro",
        "Brasília",
        "Belo Horizonte",
      ],
      tags: [] as ITags[],
    };
  },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "DashBoard" });
    },
    voltarPagina() {
      this.$router.push({ name: "DevRegisterExperiences" });
    },
    addTag(tag: ITags) {
      this.tags.push(tag);
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
  margin: 2em 25em 10em;
  height: 50em;
}
.content-dev {
  margin: 0em 1em 0;
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

.anter:hover {
  border: 2px solid #051c27;
  background: none;
  color: #051c27;
}
</style>
