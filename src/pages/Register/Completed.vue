<template>
  <ListBox>
    <div class="title">Finalizar</div>
    <form action="#">
      <div class="input-boxes">
        <div class="text is-justify-content-center">
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusamus
          quas expedita id autem cumque repellendus nam ipsam similique.
        </div>
        <div class="column mt-5">
          <img
            src="https://pas-wordpress-media.s3.amazonaws.com/content/uploads/2020/06/10125802/Blog-Headers-11.jpg"
          />
        </div>

        <div class="button input-box">
          <ButtonsRegister @click="avancarPagina"
            >Vamos começar!</ButtonsRegister
          >
        </div>
      </div>
    </form>
  </ListBox>
</template>
<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "@/components/Listas/ListBox.vue";
import ButtonsRegister from "@/components/Utils/ButtonsRegister.vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Completed",
  components: { ListBox, ButtonsRegister },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "DashBoard" });
    },
  },
});
</script>

<style lang="scss" scoped>
.box {
  margin: 2em 25em 10em;
  height: 32em;
}
.content-dev {
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
.textarea {
  width: 25em;
}
</style>
