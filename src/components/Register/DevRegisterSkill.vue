<template>
  <ListBox>
    <div class="forms content">
      <div class="form-content">
        <div class="login-form">
          <div class="title">Habilidade</div>
          <form action="#">
            <span class="text">
              <strong> Destas experiencias de trabalho, quais se adequam a você? </strong>
            </span>
            <Stack />
            <Tag />
            <TextRegister :placeholder="skill" :icon="skillIcon" />
            <SelectRegister :icon="inglesIcon">
              <option value="default" selected>
                Selecione o seu nível de inglês
              </option>
              <option value="Nenhum">Nenhum</option>
              <option value="Básico">Básico</option>
              <option value="Intermediário">Intermediário</option>
              <option value="Avançado">Avançado</option>
            </SelectRegister>
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
import ListBox from "../Listas/ListBox.vue";
import ButtonsRegister from "../Utils/ButtonsRegister.vue";
import TextRegister from "../Utils/TextRegister.vue";
import Tag from "../Utils/Tag.vue";
import Stack from "../Utils/Stack.vue";
import SelectRegister from "../Utils/SelectRegister.vue";
export default defineComponent({
  name: "DevRegisterSkill",
  data() {
    return {
      skill: "Digite uma experiência de tecnologia",
      skillIcon: "fas fa-code",
      inglesIcon: "fas fa-language",
      btnAnterior: "anter",
    };
  },
  components: {
    ListBox,
    ButtonsRegister,
    TextRegister,
    Tag,
    Stack,
    SelectRegister,
  },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "DevSobre" });
    },
    voltarPagina() {
      this.$router.push({ name: "DevRegisterCarreira" });
    },
  },
});
</script>

<style lang="scss" scoped>
@import url("Secondary.scss");
.text {
  text-align: left;
}
.box {
  height: 35em;
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
