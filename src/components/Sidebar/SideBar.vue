<template>
  <header>
    <h1>
      <img
        src="https://img.freepik.com/free-photo/tropical-palm-leaves-monstera-pink-background-flat-lay-top-view-minimal-concept_46686-199.jpg?w=2000"
        alt="avatar"
        id="avatar"
      />
    </h1>
    <button class="button" @click="alterTheme">
      {{ txtButton }}
    </button>
  </header>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  name: "SideBar",
  emits: ['alteredTheme'],
  data () {
    return {
      darkMode: false,
    }
  },
  computed: {
    txtButton () {
      if (this.darkMode) {
        return 'desativar modo escuro'
      }
      return 'ativar modo escuro'
    }
  },
  methods: {
    alterTheme () {
      this.darkMode = !this.darkMode
      this.$emit('alteredTheme', this.darkMode) 
    }
  }
});
</script>

<style scoped>
@import url("./style.scss");
</style>
