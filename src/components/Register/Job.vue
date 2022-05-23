<template>
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
          <Tag
            :placeholder="modalidade"
            :icon="iconTitulacao"
            :options="modalidadeArray"
          />
          <Tag
            :placeholder="cidade"
            :icon="iconTitulacao"
            :options="cidadeArray"
          />
          <div class="is-flex" id="career">
            <TextSalaryRegister>PJ</TextSalaryRegister>
            <TextSalaryRegister>CLT</TextSalaryRegister>
          </div>
        </form>
      </div>
    </div>
  </div>
  <div class="input-box is-flex button-space-between">
    <ButtonsRegister @click="avancarPagina">Adicionar</ButtonsRegister>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ButtonsRegister from "../Utils/ButtonsRegister.vue";
import TextSalaryRegister from "../Utils/TextSalaryRegister.vue";
import TextRegister from "../Utils/TextRegister.vue";
import Tag from "../Utils/Tag.vue";
import ITags from "@/interface/ITags";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Job",
  components: {
    ButtonsRegister,
    TextSalaryRegister,
    TextRegister,
    Tag,
  },
  data() {
    return {
      titulacao: "Digite como você se intitula",
      modalidade: "Selecione a modalidade de trabalho desejada",
      modalidadeIcon: "fa-solid fa-house-laptop",
      iconTitulacao: "fas fa-brain",
      cidade: "Digite uma cidade de preferência",
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
      this.$router.push({ name: "DevRegisterSkill" });
    },
    voltarPagina() {
      this.$router.push({ name: "DevRegister" });
    },
    addTag(tag: ITags) {
      this.tags.push(tag);
    },
    close() {
      this.$emit("close");
    },
  },
});
</script>

<style scoped>
@import url("Primary.scss");
textarea.textarea {
  border-bottom: rgba(0, 0, 0, 0.2) 2px solid;
  border-top: none;
  border-right: none;
  border-left: none;
  border-radius: 0;
  box-shadow: none;
  max-height: 3em;
  padding: 0 1em 0;
}

textarea.textarea::placeholder {
  font-size: 1em;
  font-weight: 600;
  color: rgba(0, 0, 0, 0.2);
}

.button-space-between {
  justify-content: right;
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

#career {
  margin: 0;
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
