<template>
  <ListBox>
    <div class="forms content">
      <div class="form-content">
        <div class="login-form">
          <div class="title">Carreira</div>
          <form action="#">
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
              </div>
            </div>
            <TextRegister :placeholder="titulacao" :icon="iconTitulacao" />
            <Tag></Tag>
            <SelectRegister :icon="modalidadeIcon">
              <option value="default" default>Selecione um formato de trabalho desejado</option>
              <option value="remoto">Remoto</option>
              <option value="presencial">Presencial</option>
              <option value="hibrido">Híbrido</option>
            </SelectRegister>
            <div class="is-flex">
              <TextSalaryRegister>PJ</TextSalaryRegister>
              <TextSalaryRegister>CLT</TextSalaryRegister>
            </div>
          </form>
        </div>
      </div>
    </div>
    <div class="input-box is-flex button-space-between">
      <ButtonsRegister @click="voltarPagina" :class="btnAnterior"
        >Anterior</ButtonsRegister
      >
      <ButtonsRegister @click="avancarPagina" >Next</ButtonsRegister>
    </div>
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "../Listas/ListBox.vue";
import ButtonsRegister from "../Utils/ButtonsRegister.vue";
import TextSalaryRegister from "../Utils/TextSalaryRegister.vue";
import TextRegister from "../Utils/TextRegister.vue";
import SelectRegister from "../Utils/SelectRegister.vue";
import Tag from "../Utils/Tag.vue";
export default defineComponent({
  name: "DevRegisterCarreira",
  components: {
    ListBox,
    ButtonsRegister,
    TextSalaryRegister,
    TextRegister,
    SelectRegister,
    Tag,
  },
  data() {
    return {
      titulacao: "Digite como você se intitula",
      modalidade: "Selecione a modalidade de trabalho desejada",
      modalidadeIcon: "fa-solid fa-house-laptop",
      iconTitulacao: "fas fa-brain",
      btnAnterior: "anter",
    };
  },
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
