<template>
  <div class="forms content">
    <div class="form-content">
      <div class="login-form">
        <div class="title">Habilidade</div>
        <form action="#">
          <span class="text">
            <strong>
              Destas experiencias de trabalho, quais se adequam a você?
            </strong>
          </span>
          <Stack />
          <SelectRegister
            :icon="skillIcon">
            <option
            v-for="skill in skillArray"
            :key="skill.id"
            :value="skill.value"
            >{{ skill.desc }}
            </option>
            </SelectRegister
          >
          <SelectRegister :icon="inglesIcon">
            <option value="default" selected>
              Selecione o seu nível de inglês
            </option>
            <option value="Não possuo experiência">
              Não possuo experiência
            </option>
            <option value="Básico">Básico</option>
            <option value="Intermediário">Intermediário</option>
            <option value="Avançado">Avançado</option>
            <option value="Fluente">Fluente</option>
          </SelectRegister>
          <span class="text">
            <strong>
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Saepe
              necessitatibus labore excepturi corrupti.
            </strong>
          </span>
          <TextRegister :placeholder="linkedIn" :icon="linkedInIcon" />
          <TextRegister :placeholder="github" :icon="githubIcon" />
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
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "@/components/Listas/ListBox.vue";
import ButtonsRegister from "@/components/Utils/ButtonsRegister.vue";
import Tag from "@/components/Utils/Tag.vue";
import Stack from "@/components/Utils/Stack.vue";
import TextRegister from "@/components/Utils/TextRegister.vue";
import SelectRegister from "@/components/Utils/SelectRegister.vue";
import { Skills } from "@/utils/index";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Skill",
  data() {
    return {
      linkedIn: "Digite o link de seu perfil LinkedIn",
      linkedInIcon: "fa-brands fa-linkedin",
      github: "Digite o link de seu perfil Github",
      githubIcon: "fa-brands fa-github",
      skill: "Digite uma experiência de tecnologia",
      skillIcon: "fas fa-code",
      inglesIcon: "fas fa-language",
      btnAnterior: "anter",
      skillArray: Skills
    };
  },
  components: {
    ButtonsRegister,
    
    Stack,
    SelectRegister,
    TextRegister
  },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "DevRegisterExperiences" });
    },
    voltarPagina() {
      this.$router.push({ name: "DevRegisterCarreira" });
    }
  }
});
</script>

<style lang="scss" scoped>
@import url("Secondary.scss");
.text {
  text-align: left;
}
.box {
  height: 45em;
}
.anter {
  background-color: #051c27;
}
.content ul {
  list-style: disc outside;
  margin-left: 1em;
  margin-top: 1em;
}

.anter:hover {
  border: 2px solid #051c27;
  background: none;
  color: #051c27;
}
</style>
