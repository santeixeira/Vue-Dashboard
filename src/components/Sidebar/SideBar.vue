<template>
  <header>
    <h1>
      <img
        src="https://img.freepik.com/free-photo/tropical-palm-leaves-monstera-pink-background-flat-lay-top-view-minimal-concept_46686-199.jpg?w=2000"
        alt="avatar"
        id="avatar"
      />
    </h1>
    <nav class="mt-6">
      <div class="navbar-content mt-3">
        <router-link to="/dashboard" class="link">
           Dashboard 
        </router-link>
      </div>

      <div class="navbar-content mt-3">
        <router-link to="/vagas" class="link"> Perfil </router-link>
      </div>

      <div class="navbar-content mt-3">
        <router-link to="/vagas" class="link">
          <i class="fas fa-briefcase"></i> Vagas
        </router-link>
      </div>
      
    </nav>
  </header>
  <footer>
    <div class="has-text-centered">
        <button type="button" class="darkmode-button" @click="alterTheme">
          {{ txtButton }}
        </button>
      </div>
  </footer>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  name: "SideBar",
  emits: ["alteredTheme"],
  data() {
    return {
      darkMode: false,
    };
  },
  computed: {
    txtButton() {
      if (this.darkMode) {
        return "Modo escuro";
      }
      return "Modo claro";
    },
  },
  methods: {
    alterTheme() {
      this.darkMode = !this.darkMode;
      this.$emit("alteredTheme", this.darkMode);
    },
  },
});
</script>

<style lang="scss">
@import url("./style.scss");
</style>
