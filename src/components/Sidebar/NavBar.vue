<template>
  <nav class="navbar" role="navigation" aria-label="main navigation">
    <div class="container">
      <div class="navbar-brand">
        <a class="navbar-item" href="https://somosjobi.com.br">
          <img
            src="https://somosjobi.com.br/wp-content/uploads/2022/03/Logo-Jobi-2.png"
            class="jobi"
          />
        </a>

        <a
          role="button"
          class="navbar-burger"
          aria-label="menu"
          aria-expanded="false"
          data-target="navbarBasicExample"
        >
          <span aria-hidden="true"></span>
          <span aria-hidden="true"></span>
          <span aria-hidden="true"></span>
        </a>
      </div>

      <div id="navbarBasicExample" class="navbar-menu">
        <div class="navbar-end">
          <div class="navbar-item">
            <input type="checkbox" @click="alterTheme">
          </div>
          <div class="navbar-item">
            <div class="navbar-item has-dropdown is-hoverable">
              <a class="navbar-link">
                <img
                  src="https://img.freepik.com/free-photo/tropical-palm-leaves-monstera-pink-background-flat-lay-top-view-minimal-concept_46686-199.jpg?w=2000"
                  class="avatar-card"
                />
                San Teixeira Tech
              </a>

              <div class="navbar-dropdown">
                <img
                  src="https://img.freepik.com/free-photo/tropical-palm-leaves-monstera-pink-background-flat-lay-top-view-minimal-concept_46686-199.jpg?w=2000"
                  class="avatar-dropdown"
                />
                <router-link to="/dashboard" class="navbar-item">
                  Dashboard
                </router-link>
                <router-link to="/dashboard" class="navbar-item">
                  Vagas
                </router-link>
                <router-link to="/dashboard" class="navbar-item">
                  Configurações
                </router-link>
                <router-link to="/dashboard" class="navbar-item">
                  Configurações
                </router-link>
                <router-link to="/dashboard" class="navbar-item">
                  Configurações
                </router-link>
                <hr class="navbar-divider" />
                <a class="navbar-item"> Sair </a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </nav>
</template>
<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  name: "NavBar",
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
<style scoped>
.navbar-link {
  color: #fff;
}

.navbar-link:hover{
  color: #000;
  border-radius: 2em 2em 0 0;
}

.navbar-dropdown{
  border-radius:  0 0 2em 2em;
}

.navbar {
  max-height: 5em;
  background: none;
}
.avatar-dropdown {
  width: 10em;
  height: 10em;
  max-height: 10em;
  -webkit-border-radius: 50%;
  -webkit-background-clip: padding-box;
  -moz-border-radius: 50%;
  -moz-background-clip: padding;
  border-radius: 50%;
  background-clip: padding-box;
  background-size: cover;
  background-position: center center;
  object-fit: cover;
}

.avatar-dropdown:hover {
  background-color: #000 75%;
}
.avatar-card {
  width: 3em;
  height: 3em;
  max-height: 3em;
  margin-right: 0.5em;
  -webkit-border-radius: 50%;
  -webkit-background-clip: padding-box;
  -moz-border-radius: 50%;
  -moz-background-clip: padding;
  border-radius: 50%;
  background-clip: padding-box;
  background-size: cover;
  background-position: center center;
  object-fit: cover;
}

.jobi {
  max-height: 5em;
}
</style>
